#pragma once

#include "FilterBase.h"

namespace OpenCVFunc {
	public ref class Canny : public FilterBase
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

			cv::Mat* outImage = new cv::Mat();
			cv::Mat dst = cv::Mat();
			cv::Mat src = cv::Mat();
			getImages(inImage, outImage, &src, &dst);

			try {
				cv::Canny(src, dst, threshold1, threshold2, apertureSize, L2gradient);
			}
			catch (...) {
				inImage = NULL;
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
