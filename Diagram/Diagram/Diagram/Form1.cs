using MindFusion.Diagramming;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            zoomControl1.BringToFront();
            ((ObservableCollection<Layer>)diagram1.Layers).CollectionChanged += Layers_CollectionChanged;                             
            diagramView1.AllowInplaceEdit = true;
            diagram1.DiagramStyle.Brush = new MindFusion.Drawing.SolidBrush(Color.FromArgb(192, 192, 255));
                        
        }

        void Layers_CollectionChanged(object sender, NotifyCollectionChangedEventArgs<Layer> e)
        {

            if (e.NewItems.Count<Layer>() > 0)
            {
                e.NewItems[0].Title = "Layer" + layerListView1.Items.Count;

            }
        }


        private void shapeToolBar1_ShapeClicked(object sender, MindFusion.Diagramming.ShapeEventArgs e)
        {
            diagram1.DefaultShape = e.Shape;

        }

        private void diagramView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                diagramView1.RightButtonActions = MindFusion.Diagramming.MouseButtonActions.Magnify;
                diagramView1.Invalidate();
            }
        }


        private Color getLayerColor(int layerIndex)
        {
            if (layerIndex % 5 == 0)
                return Color.FromArgb(102, 154, 204);

            if (layerIndex % 4 == 0)
                return Color.FromArgb(224, 233, 233);

            if (layerIndex % 3 == 0)
                return Color.FromArgb(90, 121, 165);

            if (layerIndex % 2 == 0)
                return Color.FromArgb(156, 170, 198);

            if (layerIndex % 1 == 0)
                return Color.FromArgb(192, 192, 192);

            if (layerIndex == 0)
                return Color.FromArgb(206, 0, 0);

            //no layer index
            return Color.FromArgb(192, 192, 255);

        }

        private void diagram1_NodeCreating(object sender, NodeValidationEventArgs e)
        {
            e.Node.Brush = new MindFusion.Drawing.SolidBrush(getLayerColor(diagram1.ActiveLayer));
        }
    }
}
