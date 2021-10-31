using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Graph_coloring
{
    public partial class Form1 : Form
    {
        private Graph graph;
        private DataBaseManager dataBaseManager;

        private int num = 0;

        private Graphics graphEgitorBox;

        public Form1()
        {
            InitializeComponent();

            graphEgitorBox = editorPictureBox.CreateGraphics();
            dataBaseManager = new DataBaseManager(graphEgitorBox);
            graph = new Graph(graphEgitorBox);

            ClearEditorPictureBox();
        }

        public void Coloring(bool ifStudy, int num, ref Graph graph)
        {
            int MatrixSize = graph.vertexesList.Count();

            List<int> color_indexes = new List<int>();
            for (int i = 0; i < MatrixSize; i++)
                color_indexes.Add(0);

            int[,] M = new int[MatrixSize, MatrixSize];
            for (int i = 0; i < MatrixSize; i++)
            {
                int VertexIndexI = graph.vertexesList[i].index;
                for (int j = 0; j < MatrixSize; j++)
                {
                    int VertexIndexJ = graph.vertexesList[j].index;

                    if (graph.ribsList.Contains(new Point(VertexIndexI, VertexIndexJ)))
                        M[i, j] = 1;
                    else
                        M[i, j] = 0;
                }
            }

            for (int i = 0; i < MatrixSize; i++)
            {
                for (int j = 0; j < MatrixSize; j++)
                {
                    if (M[i, j] != 0 && color_indexes[i] == color_indexes[j])
                    {
                        color_indexes[j]++;
                    }
                }
            }

            if (ifStudy)
            {
                graph.vertexesList[num].ColorVertex(graph.colorsList[color_indexes[num]]);
            }
            else
            {
                for (int i = 0; i < MatrixSize; i++)
                {
                    graph.vertexesList[i].ColorVertex(graph.colorsList[color_indexes[i]]);
                }
            }
        }

        private void Color_graph_MouseClick(object sender, MouseEventArgs e)
        {
            if (!ifSlowModeCheckBox.Checked)
            {
                Coloring(false, num, ref graph);
                return;
            }

            Coloring(true, num, ref graph);
            num++;
            if (num == graph.vertexesList.Count())
                num = 0;
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
            num = 0;
            graph.DrawGraph();
        }
    }
}
