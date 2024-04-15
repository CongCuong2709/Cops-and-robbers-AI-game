using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopAndRobber
{
	internal class SupportMethod
	{

		//func Load form into panel
		public void openChildFormDockTop(Form activeForm, Form formName, Panel panelName)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = formName;
			formName.TopLevel = false;
			formName.FormBorderStyle = FormBorderStyle.None;
			formName.Dock = DockStyle.Top;
			panelName.Controls.Add(formName);
			panelName.Tag = formName;
			formName.BringToFront();
			formName.Show();
		}

		public void AddChildFormDockTop(Form formName, Panel panelName)
		{

			formName.TopLevel = false;
			formName.FormBorderStyle = FormBorderStyle.None;
			formName.Dock = DockStyle.Top;
			panelName.Controls.Add(formName);
			panelName.Tag = formName;
			formName.BringToFront();
			formName.Show();
		}


		public void AddChildFormDockFill(Form formName, Panel panelName)
		{

			formName.TopLevel = false;
			formName.FormBorderStyle = FormBorderStyle.None;
			formName.Dock = DockStyle.Fill;
			panelName.Controls.Add(formName);
			panelName.Tag = formName;
			formName.BringToFront();
			formName.Show();
		}

		public void AddChildFormDockNone(Form formName, Panel panelName)
		{

			formName.TopLevel = false;
			formName.FormBorderStyle = FormBorderStyle.None;
			formName.Dock = DockStyle.None;
			panelName.Controls.Add(formName);
			panelName.Tag = formName;
			formName.BringToFront();
			formName.Show();
		}

		public void AddChildFormDockLeft(Form formName, Panel panelName)
		{

			formName.TopLevel = false;
			formName.FormBorderStyle = FormBorderStyle.None;
			formName.Dock = DockStyle.Left;
			panelName.Controls.Add(formName);
			panelName.Tag = formName;
			formName.BringToFront();
			formName.Show();
		}

		public void openChildFormDockFill(Form activeForm, Form formName, Panel panelName)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = formName;
			formName.TopLevel = false;
			formName.FormBorderStyle = FormBorderStyle.None;
			formName.Dock = DockStyle.Fill;
			panelName.Controls.Add(formName);
			panelName.Tag = formName;
			formName.BringToFront();
			formName.Show();
		}

        public void openTurnTableDockFill(Form activeForm, ActionBar formName, TurnTable panelName)
        {
            if (activeForm != null)
                activeForm.Close();
            formName.Dock = DockStyle.Fill;
            panelName.Controls.Add(formName);
            panelName.Tag = formName;
            formName.BringToFront();
            formName.Show();
        }

        //func get form main
        public Form getFormMain(Form container)
		{
			Form containerControl = container;
			while (containerControl.ParentForm != null)
			{
				return getFormMain(containerControl.ParentForm);
			}
			return containerControl;
		}

		//Trả về form cha theo tên (trừ form main)
		public Form getFormParent(Form container, string nameForm)
		{
			Form containerControl = container;
			while (/*containerControl.ParentForm != null || */containerControl.Name != nameForm)
			{
				return getFormParent(containerControl.ParentForm, nameForm);
			}
			if (containerControl.ParentForm == null)
			{
				return null;
			}
			else return containerControl;
		}


		public Panel getPanel(Form formName, string namepanel)
		{
			foreach (Panel c in formName.Controls.OfType<Panel>())
			{
				if (c.Name == namepanel)
					return c;
			}
			return null;
		}

		public void openChildFormFromForm(string nameFormRoot, string namePanelContainer, Form formContent, Form formLeaf)
		{
			Form formRoot = getFormParent(formLeaf as Form, nameFormRoot); // ???Làm sao để có thể ép dúng kiểu.
			Panel panelContainer = getPanel(formRoot, namePanelContainer);
			foreach (Control control in panelContainer.Controls)
			{
				control.Dispose();
			}
			AddChildFormDockFill(formContent, panelContainer);
		}

		
	}
}
