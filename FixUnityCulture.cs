using System.Globalization;
using System.Threading;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Pepengineers
{
#if UNITY_EDITOR
	[InitializeOnLoad]
	internal static class FixCultureEditor
	{
		static FixCultureEditor()
		{
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
		}
	}
#endif

	internal static class FixCultureRuntime
	{
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void FixCulture()
		{
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
		}
	}
}