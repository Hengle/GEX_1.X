--[[
	Author： LiangZG
	Email :  game.liangzg@foxmail.com
]]

--[[
	Desc:
]]

UISkill = {}
local this = UISkill

--[[
	初始化，资源实例后执行，仅执行一次
	LuaUIPage  basePage   依附GameObject结点的UIPage对象  
]]
function UISkill.OnAwake(basePage)

    basePage:SetPage(EPageType.Normal , EShowMode.HideOther , ECollider.Normal)

    -- upgrade result info 
    basePage:AddClick("desc/btn_upgrade" , function()
        UIManager:Show("UISkillUpdate" , nil)
    end)

    --goto batlle
    basePage:AddClick("desc/btn_battle" , function()
        UIManager:Show("UIBattle" , nil)    
    end)

end

--[[
	界面显示，每次界面显示时都将执行
	object pageData   界面显示时的传参（可空）
]]
function UISkill.OnShow(pageData)


end

--[[
	界面隐藏，每次界面隐藏都将执行
]]
function UISkill.OnHide()


end

--[[
	界面销毁资源时调用，全生命周期，只会执行一次
]]
function UISkill.OnDestroy()

end

