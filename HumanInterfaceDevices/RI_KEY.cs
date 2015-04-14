﻿using System;

namespace Win32.HumanInterfaceDevices
{
	/// <summary>
	/// Defines flags for scan code information.
	/// </summary>
	[CLSCompliant(false)]
	[Flags]
	public enum RI_KEY : ushort
	{
		/// <summary>
		/// The key is down.
		/// </summary>
		MAKE=0,

		/// <summary>
		/// The key is up.
		/// </summary>
		BREAK=1,

		/// <summary>
		/// This is the left version of the key.
		/// </summary>
		E0=2,

		/// <summary>
		/// This is the right version of the key.
		/// </summary>
		E1=4,
	}
}