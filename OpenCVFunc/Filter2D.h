#pragma once

#include <opencv2/opencv.hpp>
#include <msclr/marshal_cppstd.h>
#include "ImageMemManager.h"
#include "Util.h"

using namespace System;

namespace OpenCVFunc {
	public ref class Filter2D
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
			try {
				cv::filter2D(*inImage, *outImage, ddepth, k, cv::Point(anchorX, anchorY), delta, borderType);
			}
			catch (...) {
				delete (outImage);
				throw;
			}

			ImageMemManager::SetImage(outImage, imageOutNo);


			return Util::GetInOutParam(inImage, outImage);

		}

	};
}

