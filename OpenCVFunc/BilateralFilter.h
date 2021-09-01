#pragma once

#include "FilterBase.h"

namespace OpenCVFunc {

	public ref class BilateralFilter : public FilterBase
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

			cv::Mat* outImage = new cv::Mat();
			cv::Mat dst = cv::Mat();
			cv::Mat src = cv::Mat();

			getImages(inImage, outImage, &src, &dst);

			try {
				cv::bilateralFilter(src, dst, d, sigmaColor, sigmaSpace, borderType);
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

