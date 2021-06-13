#pragma once
#include <opencv2/opencv.hpp>
#include <msclr/marshal_cppstd.h>
#include "ImageMemManager.h"
#include "Util.h"

using namespace System;

namespace OpenCVFunc {
	public ref class BitDepthConverter
	{
	public:
		String^ BitDepthConverter_exec(
			int type,
			double alpha,
			double beta,
			int imageInNo,
			int imageOutNo) 
		{

			cv::Mat* inImage = ImageMemManager::GetImage(imageInNo);
			if (inImage == nullptr) { return "no input image"; }


			cv::Mat* outImage = new cv::Mat;
			try {
				inImage->convertTo(*outImage, type,alpha,beta);
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

