//
//  StructureData.h
//  typescript-mac
//
//  Created by 朱嘉灵 on 2020/3/3.
//  Copyright © 2020 朱嘉灵. All rights reserved.
//

#ifndef StructureData_h
#define StructureData_h

struct StructureData
{
    void* data;
    size_t size;
    
    StructureData(const size_t& size) : data(size ? malloc(size) : nullptr), size(size) { }
    ~StructureData()
    {
        if (data)
        {
            free(data);
        }
    }
};

#endif /* StructureData_h */
