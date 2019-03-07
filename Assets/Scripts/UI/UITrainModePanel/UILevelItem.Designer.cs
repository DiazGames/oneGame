/****************************************************************************
 * 2019.3 风漫云端的MacBook Pro
 ****************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace oneGame
{
	public partial class UILevelItem
	{
		[SerializeField] public Text TxtLevelName;

		public void Clear()
		{
			TxtLevelName = null;
		}

		public override string ComponentName
		{
			get { return "UILevelItem";}
		}
	}
}
