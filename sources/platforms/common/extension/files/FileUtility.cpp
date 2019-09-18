#include "FileUtility.h"
#include "delegates.h"
#include <vector>
#include "defines.h"

extern OnReadStringFromFile sReadStringFromFileCallback;

std::string FileUtility::ReadStringFromFile(const char* filename)
{
	return sReadStringFromFileCallback ? sReadStringFromFileCallback(filename) : "";
}

std::string FileUtility::ReadStringFromFile(const std::string& filename)
{
	return FileUtility::ReadStringFromFile(filename.c_str());
}

std::string FileUtility::GetDirectoryName(const std::string& path)
{
	if (path.empty())
	{
		return path;
	}

	size_t index = (size_t)max((int)path.find_last_of('/'), (int)path.find_last_of('\\'));
	return path.substr(0, index);
}

std::vector<std::string> splitPath(const std::string& path)
{
	std::vector<std::string> results;
	results.reserve(16);
	char buffer[256] { };
	strcpy(buffer, path.c_str());
	char* p = strtok(buffer, "/\\");
	while (p)
	{
		results.emplace_back(p);
		p = strtok(nullptr, "/\\");
	}
	return results;
}

std::string FileUtility::CombinePath(const std::string& path1, const std::string& path2)
{
	std::vector<std::string> parts1 = splitPath(path1);
	std::vector<std::string> parts2 = splitPath(path2);
	while (parts2.size() > 0)
	{
		std::string first = parts2[0];
		parts2.erase(parts2.begin());
		const char* value = first.c_str();
		if (!strcmp(".", value))
		{
			continue;
		}
		else if (!strcmp("..", value))
		{
			parts1.pop_back();
		}
		else
		{
			parts1.emplace_back(first);
		}
	}

	//for (auto iterator = parts1.rbegin(); iterator != parts1.rend(); --iterator)
	//{

	//}

	std::string result = "";
	for (auto iterator : parts1)
	{
		if (!result.empty())
		{
			result.append("/");
		}
		result.append(iterator);
	}
	return result;
}

