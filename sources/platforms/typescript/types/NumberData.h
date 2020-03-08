//
//  NumberData.h
//  typescript-mac
//
//  Created by 朱嘉灵 on 2020/2/29.
//  Copyright © 2020 朱嘉灵. All rights reserved.
//

#ifndef NumberData_h
#define NumberData_h

union NumberData
{
    bool boolean;
    char int8;
    unsigned char uint8;
    short int16;
    unsigned short uint16;
    int int32;
    unsigned int uint32;
    long long int64;
    unsigned long long uint64;
    float float32;
    double float64;
};

#endif /* NumberData_h */
