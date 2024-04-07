using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopAndRobber
{
	internal class GuiUtils
	{
		public static int GO_LEFT_NUM_FRAME = 4;
		public static int GO_RIGHT_NUM_FRAME = 4;
		public static int CATCH_NUM_FRAME = 4;
		public static int WAIT_NUM_FRAME = 4;

		public static int CAT_WIDTH;
		public static int CAT_HEIGHT;

		public static int MOUSE_WIDTH;
		public static int MOUSE_HEIGHT;

		public static Image LOGO = Image.FromFile(Application.StartupPath + "\\Assets\\menuInterface.png");
		public static Image[] TOM_GO_LEFT_SPRITE = getSprite("Tom", "go_left", GO_LEFT_NUM_FRAME);
		public static Image[] TOM_GO_RIGHT_SPRITE = getSprite("Tom", "go_left", GO_RIGHT_NUM_FRAME);
		public static Image[] TOM_CATCH = getSprite("Tom", "go_left", CATCH_NUM_FRAME);
		public static Image[] TOM_WAIT = getSprite("Tom", "go_left", WAIT_NUM_FRAME);

		

		private static Image[] getSprite(string nameCharacter ,string nameAction, int numFrame)
		{
			Image[] sprite;
			sprite = new Image[numFrame];

			for(int index = 0; index < numFrame; index++)
			{
				string path = Application.StartupPath + "\\Assets\\" + nameCharacter + "\\" + nameAction + index + ".png";
				//DialogResult dialogResult = MessageBox.Show(path, "", MessageBoxButtons.YesNo);
				sprite[index] = Image.FromFile(path);
			}

			return sprite;
		}

		public enum STATE_CHARACTER
		{
			WAIT,
			GO_LEFT,
			GO_RIGHT,
			CATCH,
		}

		public enum CHARACTER
		{
			TOM,
			BUTCH,
			JONES,
			JERRY,			
		}
	}
}
