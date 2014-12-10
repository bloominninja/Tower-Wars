using System;
using System.ComponentModel;
using LaughingDogStudios.Salvage.Logic.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Containers;

namespace LaughingDogStudios.Salvage.Logic.Models.User.GameCode.Server.Data
{
	[TypeConverter(typeof(TypeConverterGeneric<RandomData>))]
	public class RandomData : TriggerData
	{
		public override bool OnFunctionNotFoundCallTorqueScript()
		{
			return false;
		}

		private void onInitVars()
		{
			//console.print("hi");
			System.Windows.Forms.MessageBox.Show("hello");
		} //onInitVars

		public override void onAdd(GameBase obj)
		{
			var a = new ScriptMsgListener();
			//a.
			//game._gameBase.EventManager.EventManager_subscribe(gameDM.Event.ToString(), gameDM.Event.initGameVars, "onInitvars");
			//

			//omni.console.print("hello");
			//omni.console.commandToServer("delete(this)");

			//this.schedule("1000", "delete");
			this.setHidden(true);
			//omni.EventManager.
		}

		#region AutoGen Operator Overrides

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ts"></param>
		/// <param name="simobjectid"></param>
		/// <returns></returns>
		public static bool operator ==(RandomData ts, string simobjectid)
		{
			if (ReferenceEquals(ts, null))
				return ReferenceEquals(simobjectid, null);
			return ts.Equals(simobjectid);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj)
		{
			return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ts"></param>
		/// <param name="simobjectid"></param>
		/// <returns></returns>
		public static bool operator !=(RandomData ts, string simobjectid)
		{
			if (ReferenceEquals(ts, null))
				return !ReferenceEquals(simobjectid, null);
			return !ts.Equals(simobjectid);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ts"></param>
		/// <returns></returns>
		public static implicit operator string(RandomData ts)
		{
			if (ReferenceEquals(ts, null))
				return "0";
			return ts._ID;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ts"></param>
		/// <returns></returns>
		public static implicit operator RandomData(string ts)
		{
			uint simobjectid = resolveobject(ts);
			return (RandomData)Omni.self.getSimObject(simobjectid, typeof(RandomData));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ts"></param>
		/// <returns></returns>
		public static implicit operator int(RandomData ts)
		{
			if (ReferenceEquals(ts, null))
				return 0;
			int i;
			return int.TryParse(ts._ID, out i) ? i : 0;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="simobjectid"></param>
		/// <returns></returns>
		public static implicit operator RandomData(int simobjectid)
		{
			return (RandomData)Omni.self.getSimObject((uint)simobjectid, typeof(RandomData));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ts"></param>
		/// <returns></returns>
		public static implicit operator uint(RandomData ts)
		{
			if (ReferenceEquals(ts, null))
				return 0;
			uint i;
			return uint.TryParse(ts._ID, out i) ? i : 0;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static implicit operator RandomData(uint simobjectid)
		{
			return (RandomData)Omni.self.getSimObject(simobjectid, typeof(RandomData));
		}

		#endregion
	} //RandomData
}