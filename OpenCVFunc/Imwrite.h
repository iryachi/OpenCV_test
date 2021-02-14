#pragma once


#include <opencv2/opencv.hpp>
#include <msclr/marshal_cppstd.h>
#include "ImageMemManager.h"
#include "Util.h"

using namespace System;
using namespace System::Collections::Generic;
namespace OpenCVFunc {
	public ref class Imwrite
	{
	public:
		String^ imwrite_exec(String^ filePath, List<int>^ flags, int imageInNo)
		{
			std::string s = msclr::interop::marshal_as<std::string>(filePath);

			cv::Mat* inImage = ImageMemManager::GetImage(imageInNo);
			if (inImage == nullptr) { return "no input image"; }

			std::vector<int> compression_params;
			for each (int var in flags)
			{
				compression_params.push_back(var);
			}
			

			cv::imwrite(s, *inImage, compression_params	);


			String^ nl = System::Environment::NewLine;
			String^ retStr = "image param" + nl;
			retStr += Util::GetParam(inImage);

			return retStr;
		}

	};
}

