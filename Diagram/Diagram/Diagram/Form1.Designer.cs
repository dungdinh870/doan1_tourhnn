namespace Diagram
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.components = new System.ComponentModel.Container();
            this.ruler1 = new MindFusion.Diagramming.WinForms.Ruler();
            this.diagramView1 = new MindFusion.Diagramming.WinForms.DiagramView();
            this.diagram1 = new MindFusion.Diagramming.Diagram();
            this.zoomControl1 = new MindFusion.Common.WinForms.ZoomControl();
            this.shapeToolBar1 = new MindFusion.Diagramming.WinForms.ShapeToolBar();
            this.layerListView1 = new MindFusion.Diagramming.WinForms.LayerListView();
            this.ruler1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ruler1
            // 
            this.ruler1.AllowDrop = true;
            this.ruler1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            //this.ruler1.Controls.Add(this.diagramView1);
            this.ruler1.Controls.Add(this.zoomControl1);
            this.ruler1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruler1.Location = new System.Drawing.Point(1, 325);
            this.ruler1.Name = "ruler1";
            this.ruler1.Size = new System.Drawing.Size(785, 129);
            this.ruler1.TabIndex = 0;
            this.ruler1.Text = "ruler1";
            this.ruler1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // diagramView1
            // 
            this.diagramView1.Diagram = this.diagram1;
            this.diagramView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramView1.LicenseKey = null;
            this.diagramView1.Location = new System.Drawing.Point(18, 18);
            this.diagramView1.Name = "diagramView1";
            this.diagramView1.Size = new System.Drawing.Size(767, 111);
            this.diagramView1.TabIndex = 3;
            this.diagramView1.Text = "diagramView1";
            this.diagramView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.diagramView1_MouseClick);
            // 
            // diagram1
            // 
            this.diagram1.TouchThreshold = 0F;
            this.diagram1.NodeCreating += new System.EventHandler<MindFusion.Diagramming.NodeValidationEventArgs>(this.diagram1_NodeCreating);
            // 
            // zoomControl1
            // 
            this.zoomControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomControl1.BackColor = System.Drawing.Color.Transparent;
            this.zoomControl1.Location = new System.Drawing.Point(1191, 18);
            this.zoomControl1.Name = "zoomControl1";
            this.zoomControl1.Padding = new System.Windows.Forms.Padding(5);
            this.zoomControl1.Size = new System.Drawing.Size(62, 78);
            this.zoomControl1.TabIndex = 4;
            //this.zoomControl1.Target = this.diagramView1;
            this.zoomControl1.TickPosition = MindFusion.Common.WinForms.TickPosition.Left;
            // 
            // shapeToolBar1
            // 
            this.shapeToolBar1.ButtonImageSize = new System.Drawing.Size(24, 24);
            this.shapeToolBar1.DropDownArrows = true;
            this.shapeToolBar1.Location = new System.Drawing.Point(0, 0);
            this.shapeToolBar1.Name = "shapeToolBar1";
            this.shapeToolBar1.ShapeFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.shapeToolBar1.Shapes = null;
            this.shapeToolBar1.ShowToolTips = true;
            this.shapeToolBar1.Size = new System.Drawing.Size(786, 186);
            this.shapeToolBar1.TabIndex = 1;
            this.shapeToolBar1.ShapeClicked += new System.EventHandler<MindFusion.Diagramming.ShapeEventArgs>(this.shapeToolBar1_ShapeClicked);
            // 
            // layerListView1
            // 
            this.layerListView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layerListView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            //this.layerListView1.Diagram = this.diagram1;
            this.layerListView1.ItemColor = System.Drawing.SystemColors.Control;
            this.layerListView1.Location = new System.Drawing.Point(1, 192);
            this.layerListView1.Name = "layerListView1";
            this.layerListView1.Size = new System.Drawing.Size(785, 127);
            this.layerListView1.TabIndex = 2;
            this.layerListView1.TabStop = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 455);
            this.Controls.Add(this.layerListView1);
            this.Controls.Add(this.shapeToolBar1);
            this.Controls.Add(this.ruler1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ruler1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MindFusion.Diagramming.WinForms.Ruler ruler1;
        private MindFusion.Diagramming.WinForms.DiagramView diagramView1;
        private MindFusion.Diagramming.Diagram diagram1;
        private MindFusion.Diagramming.WinForms.ShapeToolBar shapeToolBar1;
        private MindFusion.Common.WinForms.ZoomControl zoomControl1;
        private MindFusion.Diagramming.WinForms.LayerListView layerListView1;
    }
}

