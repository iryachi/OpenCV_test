#pragma once

#include "FilterBase.h"

using namespace System;

namespace OpenCVFunc {
	public ref class Filter2D : public FilterBase
	{
	public:
		String^ Filter2D_exec(
			int ddepth,
			float* kernel,
			int kernelSize,
			int anchorX,
			int anchorY,
			double delta,
			int borderType,
			int imageInNo,
			int imageOutNo
		)
		{

			cv::Mat k(kernelSize, kernelSize, CV_32F, kernel);
			
			cv::Mat* inImage = ImageMemManager::GetImage(imageInNo);
			if (inImage == nullptr) { return "no input image"; }

			cv::Mat* outImage = new cv::Mat;
			cv::Mat dst = cv::Mat();
			cv::Mat src = cv::Mat();

			getImages(inImage, outImage, &src, &dst);


			try {
				cv::filter2D(src, dst, ddepth, k, cv::Point(anchorX, anchorY), delta, borderType);
			}
			catch (...) {
				delete (outImage);
				inImage = NULL;
				throw;
			}

			ImageMemManager::SetImage(outImage, imageOutNo);

			String^ retStr = Util::GetInOutParam(inImage, outImage);
			inImage = NULL;
			return  retStr;

		}

	};
}

