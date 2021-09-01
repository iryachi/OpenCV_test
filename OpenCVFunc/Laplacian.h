#pragma once


#include "FilterBase.h"

using namespace System;

namespace OpenCVFunc {
	public ref class Laplacian : public FilterBase
	{
	public:
		String^ Laplacian_exec(
			int ddepth,
			int ksize,
			double scale,
			double delta,
			int borderType,
			int imageInNo,
			int imageOutNo
		)
		{

			cv::Mat* inImage = ImageMemManager::GetImage(imageInNo);
			if (inImage == nullptr) { return "no input image"; }

			cv::Mat* outImage = new cv::Mat();
			cv::Mat dst = cv::Mat();
			cv::Mat src = cv::Mat();

			getImages(inImage, outImage, &src, &dst);

			try {
				cv::Laplacian(src, dst, ddepth, ksize, scale, delta, borderType);
			}
			catch (...) {
				delete (outImage);
				throw;
			}

			ImageMemManager::SetImage(outImage, imageOutNo);

			String^ retStr = Util::GetInOutParam(inImage, outImage);
			inImage = NULL;
			return  retStr;

		}

	};

}
