//
//  EnvironmentIOS.hpp
//  typescript
//
//  Created by 朱嘉灵 on 2018/12/12.
//  Copyright © 2018 朱嘉灵. All rights reserved.
//

#ifndef EnvironmentIOS_hpp
#define EnvironmentIOS_hpp

#include "header.h"
#include "core/Environment.h"

class EnvironmentIOS : public Environment
{
private:
    JSContextRef mContext;
public:
    JSContextRef GetContext() { return mContext; }
protected:
    virtual void release() override;
    
    virtual bool Initialize() override;
    
    JSValueRef execute(const char* content, const char* filename);
public:
    EnvironmentIOS() { }
    ~EnvironmentIOS() { this->release(); }
    
    virtual void Bind() override;
    
    virtual std::string ExecuteString(const char *sourceContent) override;
    
    virtual std::string ExecuteScript(const char *sourceContent, const char *filename) override;
    
    virtual void* Require(const char *sourceContent, const char *filename) override;
    
    JSValueRef GetGlobalObject();
};

#endif /* EnvironmentIOS_hpp */
