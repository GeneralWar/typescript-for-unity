//
//  Exception.h
//  typescript-mac
//
//  Created by 朱嘉灵 on 2020/3/1.
//  Copyright © 2020 朱嘉灵. All rights reserved.
//

#ifndef Exception_h
#define Exception_h

#include <string>

struct Exception
{
    std::string location;
    std::string message;
    std::string stack;
    
    // For compatibility
    std::string filePath;
    size_t lineIndex;
    
    Exception() : lineIndex(0) { }
    
    std::string ToString()
    {
        std::string content = message;
        if (!location.empty())
        {
            content = location + " : " + content;
        }
        if (!stack.empty())
        {
            content += "\nSTACK:\n" + stack;
        }
        return content;
    }
};

#endif /* Exception_h */
