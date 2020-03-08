#include <string>
#pragma once

class FileUtility
{
public:
	static std::string ReadStringFromFile(const std::string& filename);
	static std::string ReadStringFromFile(const char* filename);

	static std::string GetDirectoryName(const std::string& path);
	static std::string CombinePath(const std::string& path1, const std::string& path2);
};
