Localization = {}



--��ʼ��
function Localization:InitLocalization()
    self.Keys = {}
    self.files = {}
    self.language = AppConst.Language.CHINESE

    self:SetLanguage(self.language)
    self:RegisterModule()
    self:LoadData()
end

--ע�Ṧ��ģ�����ñ�
function Localization:RegisterModule()
    local function register_module(file)
        local path = "Localization/"..self.language.."/"..file
        table.insert(self.files,path)
    end

    --ע�᲻ͬģ������ñ�
    for key, var in ipairs(AppConst.LocalizationModule) do
        register_module(var)
    end

end

--��������
function Localization:SetLanguage(languageType)
    if self.language ~= languageType then 
        self.language = languageType 
        self:ClearKeys()
        self:RegisterModule()
        self:LoadData()
    end
end

--�������ñ�
function Localization:LoadData()
    for key, var in pairs(self.files) do
        local flie = require(var)
        for key, var in pairs(flie) do
            self.Keys[key] = var
        end
    end
end

--����key��ȡvalue
function Localization:GetText(key)
    local value = self.Keys[key]
    assert(value,"not found value ,key = "..key)
    return self.Keys[key]
end

--�������
function Localization:ClearKeys()
    self.Keys = {}
end

--�����е�key��ȡ��Ӧ��value��Ȼ���滻�ı�
function Localization:ReplaceByKey(key,count,...)
    local str = self:GetText(key)
    print(str)
    return self:ReplaceText(str,count,...)
end

--�滻�ַ���
function Localization:ReplaceText(str,count,...)
    local args = {...}
    print(...)
    for key, var in ipairs(args) do
        if key > count then
            break
        end
        local match = "$"..key
        str = string.gsub(str,match,tostring(var))
    end
    
    return str
end