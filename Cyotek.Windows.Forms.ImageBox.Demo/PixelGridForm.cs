﻿using System;

namespace Cyotek.Windows.Forms.Demo
{
  // Cyotek ImageBox
  // Copyright (c) 2010-2014 Cyotek.
  // http://cyotek.com
  // http://cyotek.com/blog/tag/imagebox

  // Licensed under the MIT License. See imagebox-license.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  internal partial class PixelGridForm : BaseForm
  {
    #region Public Constructors

    public PixelGridForm()
    {
      this.InitializeComponent();
    }

    #endregion

    #region Overridden Methods

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      propertyGrid.SelectItem("ShowPixelGrid");
    }

    #endregion

    #region Event Handlers

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutDialog.ShowAboutDialog();
    }

    private void closeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    #endregion
  }
}