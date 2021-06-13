#pragma once

#include <opencv2/opencv.hpp>
#include <msclr/marshal_cppstd.h>
#include "ImageMemManager.h"
#include "Util.h"

using namespace System;

namespace OpenCVFunc {
	public ref class Laplacian
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

			cv::Mat* outImage = new cv::Mat;
			try {
				cv::Laplacian(*inImage, *outImage, ddepth, ksize, scale, delta, borderType);
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
