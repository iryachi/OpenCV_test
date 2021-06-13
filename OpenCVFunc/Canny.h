#pragma once

#include <opencv2/opencv.hpp>
#include <msclr/marshal_cppstd.h>
#include "ImageMemManager.h"
#include "Util.h"


namespace OpenCVFunc {
	public ref class Canny
	{
	public:
		String^ Canny_exec(
			double threshold1,
			double threshold2,
			int apertureSize,
			bool L2gradient,
			int imageInNo,
			int imageOutNo)
		{

			cv::Mat* inImage = ImageMemManager::GetImage(imageInNo);
			if (inImage == nullptr) { return "no input image"; }

			cv::Mat* outImage = new cv::Mat;
			try {
				cv::Canny(*inImage, *outImage, threshold1, threshold2, apertureSize, L2gradient);
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
