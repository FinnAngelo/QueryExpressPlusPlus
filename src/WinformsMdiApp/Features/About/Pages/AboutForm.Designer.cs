namespace QueryExPlusPlus.WinformsMdiApp.Features.About.Pages;

partial class AboutForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        logoPictureBox = new PictureBox();
        labelProductName = new Label();
        labelVersion = new Label();
        labelCopyright = new Label();
        labelCompanyName = new Label();
        textBoxDescription = new TextBox();
        okButton = new Button();
        ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
        SuspendLayout();
        // 
        // logoPictureBox
        // 
        logoPictureBox.Image = Resources.Qx__130x59px;
        logoPictureBox.Location = new Point(16, 16);
        logoPictureBox.Margin = new Padding(5, 4, 5, 4);
        logoPictureBox.Name = "logoPictureBox";
        logoPictureBox.Size = new Size(130, 58);
        logoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
        logoPictureBox.TabIndex = 1;
        logoPictureBox.TabStop = false;
        // 
        // labelProductName
        // 
        labelProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        labelProductName.Location = new Point(160, 16);
        labelProductName.Size = new Size(400, 27);
        labelProductName.TabIndex = 2;
        labelProductName.Text = "Product Name";
        labelProductName.TextAlign = ContentAlignment.TopLeft;

        // 
        // labelVersion
        // 
        labelVersion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        labelVersion.Location = new Point(160, 48);
        labelVersion.Size = new Size(400, 27);
        labelVersion.TabIndex = 3;
        labelVersion.Text = "Version";
        labelVersion.TextAlign = ContentAlignment.TopLeft;
        // 
        // labelCopyright
        // 
        labelCopyright.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        labelCopyright.Location = new Point(160, 80);
        labelCopyright.Size = new Size(400, 27);
        labelCopyright.TabIndex = 4;
        labelCopyright.Text = "Copyright";
        labelCopyright.TextAlign = ContentAlignment.TopLeft;

        // 
        // labelCompanyName
        // 
        labelCompanyName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        labelCompanyName.Location = new Point(160, 112);
        labelCompanyName.Size = new Size(400, 27);
        labelCompanyName.TabIndex = 5;
        labelCompanyName.Text = "Company Name";
        labelCompanyName.TextAlign = ContentAlignment.TopLeft;

        // 
        // textBoxDescription
        // 

        textBoxDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
        textBoxDescription.Location = new Point(160, 144);
        textBoxDescription.Size = new Size(400, 240);
        textBoxDescription.TabIndex = 6;
        textBoxDescription.Text = "Description";
        textBoxDescription.TextAlign = HorizontalAlignment.Left;

        textBoxDescription.Margin = new Padding(0);
        textBoxDescription.Multiline = true;
        textBoxDescription.ReadOnly = true;
        textBoxDescription.ScrollBars = ScrollBars.Both;
        textBoxDescription.TabStop = false;

        // 
        // okButton
        // 
        okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        okButton.DialogResult = DialogResult.Cancel;
        okButton.Location = new Point(448, 400);
        okButton.Size = new Size(112, 32);
        okButton.TabIndex = 7;
        okButton.Text = "&OK";

        // 
        // AboutForm
        // 
        AcceptButton = okButton;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(576, 448);

        Controls.Add(logoPictureBox);
        Controls.Add(labelProductName);
        Controls.Add(labelVersion);
        Controls.Add(labelCopyright);
        Controls.Add(labelCompanyName);
        Controls.Add(textBoxDescription);
        Controls.Add(okButton);

        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;

        ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private System.Windows.Forms.PictureBox logoPictureBox;
    private System.Windows.Forms.Label labelProductName;
    private System.Windows.Forms.Label labelVersion;
    private System.Windows.Forms.Label labelCopyright;
    private System.Windows.Forms.Label labelCompanyName;
    private System.Windows.Forms.TextBox textBoxDescription;
    private System.Windows.Forms.Button okButton;
}
