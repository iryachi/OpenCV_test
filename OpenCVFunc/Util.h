#pragma once


#include <opencv2/opencv.hpp>
#include <msclr/marshal_cppstd.h>
#include "ImageMemManager.h"

using namespace System;


static ref class Util
{
public:
	static String^ GetParam(cv::Mat* img) {
		int width = img->cols;
		int height = img->rows;

		int channel = CV_MAT_CN(img->flags);
		int depth = CV_MAT_DEPTH(img->flags);
		cv::String depthStr = cv::depthToString(depth);

		String^ nl = System::Environment::NewLine;
		String^ str = "width : " + width.ToString() + nl;
		str += "height : " + height.ToString() + nl;
		str += "channel: " + channel.ToString() + nl;
		str += "depth : " + msclr::interop::marshal_as<System::String^>(depthStr) + nl;

		return str;
	}

	static String^ GetInOutParam(cv::Mat* inImg, cv::Mat* outImg)
	{
		String^ nl = System::Environment::NewLine;
		String^ retStr = "input image param" + nl;
		retStr += Util::GetParam(inImg);
		retStr += nl + "output image param" + nl;
		retStr += Util::GetParam(outImg);

		return retStr;
	}

};

