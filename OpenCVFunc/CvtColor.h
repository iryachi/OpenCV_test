#pragma once


#include <opencv2/opencv.hpp>
#include <msclr/marshal_cppstd.h>
#include "ImageMemManager.h"
#include "Util.h"


namespace OpenCVFunc {
	public ref class CvtColor
	{
	public:
		String^ cvtColor_exec(int code, int dstCn, int imageInNo, int imageOutNo) {
			cv::Mat* inImage = ImageMemManager::GetImage(imageInNo);
			if (inImage == nullptr) { return "no input image"; }
			cv::Mat* outImage = new cv::Mat;
			cv::cvtColor(*inImage, *outImage, code, dstCn);
			ImageMemManager::SetImage(outImage, imageOutNo);


			return Util::GetInOutParam(inImage, outImage);
		}
	};

}