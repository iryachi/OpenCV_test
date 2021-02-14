#pragma once


#include <opencv2/opencv.hpp>
#include <msclr/marshal_cppstd.h>
#include "ImageMemManager.h"
#include "Util.h"

using namespace System;


namespace OpenCVFunc {
	public ref class Imread
	{

	public:
		/// <summary>
		/// ƒtƒ@ƒCƒ‹“Ç‚İ‚İ
		/// </summary>
		/// <param name="filePath"></param>
		String^ imread_exec(String^ filePath, int flags, int imageOutNo)
		{
			std::string s = msclr::interop::marshal_as<std::string>(filePath);
			cv::Mat image = cv::imread(s, flags);

			ImageMemManager::SetImage(new cv::Mat(image), imageOutNo);
	

			String^ nl = System::Environment::NewLine;
			String^ retStr = "image param" + nl;
			retStr += Util::GetParam(&image);

			return retStr;
		}

	

	};
}
