#pragma once

#include "Util.h"

namespace OpenCVFunc {

	public ref class BilateralFilter
	{
	public:
		String^ Bilateral_exec(
			int d,
			double sigmaColor,
			double sigmaSpace,
			int borderType,
			int imageInNo,
			int imageOutNo
		)
		{
			cv::Mat* inImage = ImageMemManager::GetImage(imageInNo);
			if (inImage == nullptr) { return "no input image"; }

			cv::Mat* outImage = new cv::Mat;
			try {
				cv::bilateralFilter(*inImage, *outImage, d, sigmaColor, sigmaSpace, borderType);
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

