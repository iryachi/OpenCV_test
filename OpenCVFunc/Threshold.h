#pragma once

#include <opencv2/opencv.hpp>
#include <msclr/marshal_cppstd.h>
#include "ImageMemManager.h"
#include "Util.h"

using namespace System;
using namespace System::Collections::Generic;

namespace OpenCVFunc {
	public ref class Threshold
	{
		// TODO: このクラスのメソッドをここに追加します。
	public:
		String^ threshold_exec(double thresh, double maxval, int type,int imageInNo, int imageOutNo)
		{
			cv::Mat* inImage = ImageMemManager::GetImage(imageInNo);
			if (inImage == nullptr) { return "no input image"; }
			cv::Mat* outImage = new cv::Mat;
			cv::threshold(*inImage, *outImage, thresh, maxval, type);
			ImageMemManager::SetImage(outImage, imageOutNo);
			
			String^ nl = System::Environment::NewLine;
			String^ retStr = "input image param" + nl;
			retStr += Util::GetParam(inImage);
			retStr += nl + "output image param" + nl;
			retStr += Util::GetParam(outImage);
			
			return retStr;
		}
			

	};
}
