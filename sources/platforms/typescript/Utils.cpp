#include "Utils.h"

std::string GetSafeType(const char* origin)
{
	std::string type(origin);
	size_t index = std::string::npos;
	while (std::string::npos != (index = type.find('+')))
	{
		type = type.replace(index, 1, ".");
	}
	return type;
}
