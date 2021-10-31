using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Graph_coloring
{
    public partial class Form1 : Form
    {
        private Graphics graphEgitorBox;
        private DataBaseManager dataBaseManager;
        private Graph graph;

        public Form1()
        {
            InitializeComponent();

            graphEgitorBox = editorPictureBox.CreateGraphics();
            dataBaseManager = new DataBaseManager(graphEgitorBox);
            graph = new Graph(graphEgitorBox);

            ClearEditorPictureBox();
        }


        private void Color_graph_MouseClick(object sender, MouseEventArgs e)
        {
            graph.Coloring(ifSlowModeCheckBox.Checked);
        }

        private void Save_MouseClick(object sender, MouseEventArgs e)
        {
            dataBaseManager.SaveToFile(ref graph);
        }

        private void Create_MouseClick(object sender, MouseEventArgs e)
        {
            ClearEditorPictureBox();
            graph = new Graph(editorPictureBox.CreateGraphics());
        }

        private void Open_MouseClick(object sender, MouseEventArgs e)
        {
            ClearEditorPictureBox();
            graph = dataBaseManager.Open();
            graph.DrawGraph();
        }

        private void ClearEditorPictureBox()
        {
            graphEgitorBox.Clear(Color.White);
        }

        private void editorPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (addVertexButton.Focused)
            {
                graph.AddVertex(new Point(e.X, e.Y));
            }
            else if (addEdgeButton.Focused)
            {
                if (graph.CheckIfClickedOnVert(new Point(e.X, e.Y)) && graph.CountSelectedVertexes() == 2)
                    graph.AddRib();
            }
            else if (deleteVertexButon.Focused)
            {
                graph.DeleteVertex(new Point(e.X, e.Y));
                ClearEditorPictureBox();
                graph.DrawGraph();
            }
            else if (deleteEdgeButton.Focused &&
                     graph.CheckIfClickedOnVert(new Point(e.X, e.Y)) && 
                     graph.CountSelectedVertexes() == 2)
            {
                graph.DeleteRib();
                ClearEditorPictureBox();
                graph.UnselectAll();
                graph.DrawGraph();
            }
            else if (MoveVertexButton.Focused)
            {
                if (graph.CheckIfClickedOnVert(new Point(e.X, e.Y)))
                {
                    if (graph.CountSelectedVertexes() == 2)
                    {
                        ClearEditorPictureBox();
                        graph.UnselectAll();
                        graph.DrawGraph();
                    }
                }
                else
                {
                    graph.MoveVertex(new Point(e.X, e.Y));
                    ClearEditorPictureBox();
                    graph.DrawGraph();
                }
            }
        }

        private void colorGraphButton_Leave(object sender, System.EventArgs e)
        {
            ClearEditorPictureBox();
            graph.DrawGraph();
        }
    }
}
