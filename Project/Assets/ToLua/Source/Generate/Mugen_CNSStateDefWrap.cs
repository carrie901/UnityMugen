﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Mugen_CNSStateDefWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Mugen.CNSStateDef), typeof(System.Object));
		L.RegFunction("New", _CreateMugen_CNSStateDef);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Sprpriority", get_Sprpriority, set_Sprpriority);
		L.RegVar("PhysicsType", get_PhysicsType, set_PhysicsType);
		L.RegVar("MoveType", get_MoveType, set_MoveType);
		L.RegVar("Type", get_Type, set_Type);
		L.RegVar("PowerAdd", get_PowerAdd, set_PowerAdd);
		L.RegVar("Animate", get_Animate, set_Animate);
		L.RegVar("Ctrl", get_Ctrl, set_Ctrl);
		L.RegVar("Velset_y", get_Velset_y, set_Velset_y);
		L.RegVar("Juggle", get_Juggle, set_Juggle);
		L.RegVar("Velset_x", get_Velset_x, set_Velset_x);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateMugen_CNSStateDef(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Mugen.CNSStateDef obj = new Mugen.CNSStateDef();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Mugen.CNSStateDef.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Sprpriority(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSStateDef obj = (Mugen.CNSStateDef)o;
			int ret = obj.Sprpriority;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Sprpriority on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PhysicsType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSStateDef obj = (Mugen.CNSStateDef)o;
			Mugen.Cns_PhysicsType ret = obj.PhysicsType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index PhysicsType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MoveType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSStateDef obj = (Mugen.CNSStateDef)o;
			Mugen.Cns_MoveType ret = obj.MoveType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index MoveType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Type(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSStateDef obj = (Mugen.CNSStateDef)o;
			Mugen.Cns_Type ret = obj.Type;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Type on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PowerAdd(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSStateDef obj = (Mugen.CNSStateDef)o;
			int ret = obj.PowerAdd;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index PowerAdd on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Animate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSStateDef obj = (Mugen.CNSStateDef)o;
			int ret = obj.Animate;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Animate on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Ctrl(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSStateDef obj = (Mugen.CNSStateDef)o;
			int ret = obj.Ctrl;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Ctrl on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Velset_y(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSStateDef obj = (Mugen.CNSStateDef)o;
			float ret = obj.Velset_y;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Velset_y on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Juggle(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSStateDef obj = (Mugen.CNSStateDef)o;
			int ret = obj.Juggle;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Juggle on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Velset_x(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSStateDef obj = (Mugen.CNSStateDef)o;
			float ret = obj.Velset_x;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Velset_x on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Sprpriority(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSStateDef obj = (Mugen.CNSStateDef)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.Sprpriority = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Sprpriority on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_PhysicsType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSStateDef obj = (Mugen.CNSStateDef)o;
			Mugen.Cns_PhysicsType arg0 = (Mugen.Cns_PhysicsType)ToLua.CheckObject(L, 2, typeof(Mugen.Cns_PhysicsType));
			obj.PhysicsType = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index PhysicsType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_MoveType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSStateDef obj = (Mugen.CNSStateDef)o;
			Mugen.Cns_MoveType arg0 = (Mugen.Cns_MoveType)ToLua.CheckObject(L, 2, typeof(Mugen.Cns_MoveType));
			obj.MoveType = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index MoveType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Type(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSStateDef obj = (Mugen.CNSStateDef)o;
			Mugen.Cns_Type arg0 = (Mugen.Cns_Type)ToLua.CheckObject(L, 2, typeof(Mugen.Cns_Type));
			obj.Type = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Type on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_PowerAdd(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSStateDef obj = (Mugen.CNSStateDef)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.PowerAdd = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index PowerAdd on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Animate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSStateDef obj = (Mugen.CNSStateDef)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.Animate = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Animate on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Ctrl(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSStateDef obj = (Mugen.CNSStateDef)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.Ctrl = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Ctrl on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Velset_y(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSStateDef obj = (Mugen.CNSStateDef)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.Velset_y = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Velset_y on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Juggle(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSStateDef obj = (Mugen.CNSStateDef)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.Juggle = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Juggle on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Velset_x(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Mugen.CNSStateDef obj = (Mugen.CNSStateDef)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.Velset_x = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Velset_x on a nil value");
		}
	}
}
