﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaUIPageWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaUIPage), typeof(ABaseUIPage));
		L.RegFunction("OnAwake", OnAwake);
		L.RegFunction("OnShow", OnShow);
		L.RegFunction("OnHide", OnHide);
		L.RegFunction("OnDestroy", OnDestroy);
		L.RegFunction("AddClick", AddClick);
		L.RegFunction("RemoveClick", RemoveClick);
		L.RegFunction("ClearClick", ClearClick);
		L.RegFunction("New", _CreateLuaUIPage);
		L.RegFunction("__tostring", Lua_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLuaUIPage(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				LuaUIPage obj = new LuaUIPage();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: LuaUIPage.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnAwake(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaUIPage obj = (LuaUIPage)ToLua.CheckObject(L, 1, typeof(LuaUIPage));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			obj.OnAwake(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnShow(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaUIPage obj = (LuaUIPage)ToLua.CheckObject(L, 1, typeof(LuaUIPage));
			object arg0 = ToLua.ToVarObject(L, 2);
			obj.OnShow(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnHide(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaUIPage obj = (LuaUIPage)ToLua.CheckObject(L, 1, typeof(LuaUIPage));
			obj.OnHide();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDestroy(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaUIPage obj = (LuaUIPage)ToLua.CheckObject(L, 1, typeof(LuaUIPage));
			obj.OnDestroy();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddClick(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(LuaUIPage), typeof(string), typeof(LuaInterface.LuaFunction)))
			{
				LuaUIPage obj = (LuaUIPage)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				LuaFunction arg1 = ToLua.ToLuaFunction(L, 3);
				obj.AddClick(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(LuaUIPage), typeof(UnityEngine.GameObject), typeof(LuaInterface.LuaFunction)))
			{
				LuaUIPage obj = (LuaUIPage)ToLua.ToObject(L, 1);
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 2);
				LuaFunction arg1 = ToLua.ToLuaFunction(L, 3);
				obj.AddClick(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: LuaUIPage.AddClick");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaUIPage obj = (LuaUIPage)ToLua.CheckObject(L, 1, typeof(LuaUIPage));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			obj.RemoveClick(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaUIPage obj = (LuaUIPage)ToLua.CheckObject(L, 1, typeof(LuaUIPage));
			obj.ClearClick();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}
}

