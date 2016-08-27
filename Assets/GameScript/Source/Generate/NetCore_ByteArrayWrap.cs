﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class NetCore_ByteArrayWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(NetCore.ByteArray), typeof(System.Object));
		L.RegFunction("readBytes", readBytes);
		L.RegFunction("writeBytes", writeBytes);
		L.RegFunction("dataSize", dataSize);
		L.RegFunction("dataPtr", dataPtr);
		L.RegFunction("dataString", dataString);
		L.RegFunction("consumeByte", consumeByte);
		L.RegFunction("clearBuffer", clearBuffer);
		L.RegFunction("readInt8", readInt8);
		L.RegFunction("readInt16", readInt16);
		L.RegFunction("readInt32", readInt32);
		L.RegFunction("readInt64", readInt64);
		L.RegFunction("writeInt8", writeInt8);
		L.RegFunction("writeInt16", writeInt16);
		L.RegFunction("writeInt32", writeInt32);
		L.RegFunction("writeInt64", writeInt64);
		L.RegFunction("writeByteBuffer", writeByteBuffer);
		L.RegFunction("copyBufferPart", copyBufferPart);
		L.RegFunction("copyBufferAll", copyBufferAll);
		L.RegFunction("getBuffer", getBuffer);
		L.RegFunction("New", _CreateNetCore_ByteArray);
		L.RegFunction("__tostring", Lua_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateNetCore_ByteArray(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				NetCore.ByteArray obj = new NetCore.ByteArray();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: NetCore.ByteArray.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int readBytes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			NetCore.ByteArray obj = (NetCore.ByteArray)ToLua.CheckObject(L, 1, typeof(NetCore.ByteArray));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			byte[] o = obj.readBytes(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int writeBytes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			NetCore.ByteArray obj = (NetCore.ByteArray)ToLua.CheckObject(L, 1, typeof(NetCore.ByteArray));
			byte[] arg0 = ToLua.CheckByteBuffer(L, 2);
			obj.writeBytes(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int dataSize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NetCore.ByteArray obj = (NetCore.ByteArray)ToLua.CheckObject(L, 1, typeof(NetCore.ByteArray));
			int o = obj.dataSize();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int dataPtr(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NetCore.ByteArray obj = (NetCore.ByteArray)ToLua.CheckObject(L, 1, typeof(NetCore.ByteArray));
			int o = obj.dataPtr();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int dataString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NetCore.ByteArray obj = (NetCore.ByteArray)ToLua.CheckObject(L, 1, typeof(NetCore.ByteArray));
			string o = obj.dataString();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int consumeByte(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			NetCore.ByteArray obj = (NetCore.ByteArray)ToLua.CheckObject(L, 1, typeof(NetCore.ByteArray));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.consumeByte(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int clearBuffer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NetCore.ByteArray obj = (NetCore.ByteArray)ToLua.CheckObject(L, 1, typeof(NetCore.ByteArray));
			obj.clearBuffer();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int readInt8(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NetCore.ByteArray obj = (NetCore.ByteArray)ToLua.CheckObject(L, 1, typeof(NetCore.ByteArray));
			byte o = obj.readInt8();
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int readInt16(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NetCore.ByteArray obj = (NetCore.ByteArray)ToLua.CheckObject(L, 1, typeof(NetCore.ByteArray));
			short o = obj.readInt16();
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int readInt32(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NetCore.ByteArray obj = (NetCore.ByteArray)ToLua.CheckObject(L, 1, typeof(NetCore.ByteArray));
			int o = obj.readInt32();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int readInt64(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NetCore.ByteArray obj = (NetCore.ByteArray)ToLua.CheckObject(L, 1, typeof(NetCore.ByteArray));
			long o = obj.readInt64();
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int writeInt8(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			NetCore.ByteArray obj = (NetCore.ByteArray)ToLua.CheckObject(L, 1, typeof(NetCore.ByteArray));
			byte arg0 = (byte)LuaDLL.luaL_checknumber(L, 2);
			obj.writeInt8(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int writeInt16(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			NetCore.ByteArray obj = (NetCore.ByteArray)ToLua.CheckObject(L, 1, typeof(NetCore.ByteArray));
			short arg0 = (short)LuaDLL.luaL_checknumber(L, 2);
			obj.writeInt16(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int writeInt32(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			NetCore.ByteArray obj = (NetCore.ByteArray)ToLua.CheckObject(L, 1, typeof(NetCore.ByteArray));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.writeInt32(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int writeInt64(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			NetCore.ByteArray obj = (NetCore.ByteArray)ToLua.CheckObject(L, 1, typeof(NetCore.ByteArray));
			long arg0 = (long)LuaDLL.luaL_checknumber(L, 2);
			obj.writeInt64(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int writeByteBuffer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			NetCore.ByteArray obj = (NetCore.ByteArray)ToLua.CheckObject(L, 1, typeof(NetCore.ByteArray));
			NetCore.ByteArray arg0 = (NetCore.ByteArray)ToLua.CheckObject(L, 2, typeof(NetCore.ByteArray));
			obj.writeByteBuffer(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int copyBufferPart(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			NetCore.ByteArray obj = (NetCore.ByteArray)ToLua.CheckObject(L, 1, typeof(NetCore.ByteArray));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			NetCore.ByteArray o = obj.copyBufferPart(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int copyBufferAll(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NetCore.ByteArray obj = (NetCore.ByteArray)ToLua.CheckObject(L, 1, typeof(NetCore.ByteArray));
			NetCore.ByteArray o = obj.copyBufferAll();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getBuffer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NetCore.ByteArray obj = (NetCore.ByteArray)ToLua.CheckObject(L, 1, typeof(NetCore.ByteArray));
			byte[] o = obj.getBuffer();
			ToLua.Push(L, o);
			return 1;
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

