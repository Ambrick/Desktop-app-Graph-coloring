using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Graph_coloring
{
    public class Graph
    {
        public List<Vertex> vertexesList = new List<Vertex> { };
        public List<Point> ribsList = new List<Point> { };

        public List<Color> colorsList = new List<Color> { Color.Red, Color.Blue, Color.Green, Color.Magenta, Color.Cyan, Color.Yellow };
        public List<int> free_nums = new List<int> { };

        private const int VertexRadius = 14;

        private int num = 0;
        public int index = 0;

        private Graphics graphEgitorBox;

        public Graph(Graphics graphEgitorBox)
        {
            this.graphEgitorBox = graphEgitorBox;
        }

        public void Coloring(bool ifSlowModeCheckBox)
        {
            int MatrixSize = vertexesList.Count();

            List<int> color_indexes = new List<int>();

            for (int i = 0; i < MatrixSize; i++)
                color_indexes.Add(0);


            int matrixIlength = ifSlowModeCheckBox ? ++num : MatrixSize;

            for (int i = 0; i < matrixIlength; i++)
            {
                int VertexIndexI = vertexesList[i].index;

                for (int j = 0; j < MatrixSize; j++)
                {
                    int VertexIndexJ = vertexesList[j].index;

                    if (ribsList.Contains(new Point(VertexIndexI, VertexIndexJ)) && color_indexes[i] == color_indexes[j])
                    {
                        color_indexes[j]++;
                    }
                }
                vertexesList[i].ColorVertex(colorsList[color_indexes[i]]);
            }
        }

        public void DrawGraph()
        {
            foreach (Point point in ribsList)
                DrawRib(point);

            foreach (var vertex in vertexesList)
                vertex.Draw();

            num = 0;
        }

        private void DrawRib (Point point)
        {
            Point firstVertexPosition = vertexesList.Find(vertex => point.X == vertex.index).position;
            Point secondVertexPosition = vertexesList.Find(vertex => point.Y == vertex.index).position;

            graphEgitorBox.DrawLine(new Pen(Color.Black), firstVertexPosition, secondVertexPosition);
        }

        public void AddRib()
        {
            List<Vertex> v = new List<Vertex> { };
            foreach (var vert in vertexesList)
            {
                if (vert.IsSelected)
                {
                    v.Add(vert);
                    vert.VertexUnselected();
                }
            }

            ribsList.Add(new Point(v[0].index,v[1].index));
            DrawGraph();
        }

        public void UnselectAll()
        {
            foreach (var vert in vertexesList)
            {
                if (vert.IsSelected)
                {
                    vert.VertexUnselected();
                }
            }
        }

        public int CountSelectedVertexes()
        {
            return vertexesList.Count(vertex => vertex.IsSelected);
        }

        public bool CheckIfClickedOnVert(Point point)
        {
            Rectangle rect = new Rectangle(point.X, point.Y, 1, 1);
            
            foreach (var vert in vertexesList)
            {
                if (rect.IntersectsWith(vert.Properties) && !vert.IsSelected)
                {
                    vert.VertexSelected();
                    return true;
                }
            }

            return false;
        }

        public void AddVertex(Point point)
        {
            if (free_nums.Count() == 0)
            {
                vertexesList.Add(new Vertex(point, VertexRadius, index, graphEgitorBox));
                index++;
            }
            else
            {
                vertexesList.Add(new Vertex(point, VertexRadius, free_nums.Last(), graphEgitorBox));
                free_nums.Remove(free_nums.Last());
            }
            DrawGraph();
        }



        public void DeleteVertex(Point point)
        {
            Rectangle rect = new Rectangle(point.X, point.Y, 1, 1);

            foreach (var vert in vertexesList)
            {
                if (rect.IntersectsWith(vert.Properties))
                {
                    ForRemovingEveryRibOnVertex(vert);
                    free_nums.Add(vert.index);
                    vertexesList.Remove(vert);
                    break;
                }
            }
        }

        private void ForRemovingEveryRibOnVertex(Vertex vert)
        {
            foreach (var Point in ribsList)
            {
                if (Point.X == vert.index || Point.Y == vert.index)
                {
                    ribsList.Remove(Point);
                    ForRemovingEveryRibOnVertex(vert);
                    break;
                }
            }
        }


        public void DeleteRib()
        {
            List<Vertex> v = new List<Vertex> { };
            foreach (var vert in vertexesList)
            {
                if (vert.IsSelected)
                {
                    v.Add(vert);
                }
            }

            foreach (var Point in ribsList)
            {
                if ((Point.X == v[0].index && Point.Y == v[1].index) || (Point.Y == v[0].index && Point.X == v[1].index))
                {
                    ribsList.Remove(Point);
                    break;
                }
            }
        }

        public void MoveVertex(Point point)
        {
            foreach (var vert in vertexesList)
            {
                if (vert.IsSelected)
                {
                    vert.Move(point);
                }
            }
        }
    }
}
