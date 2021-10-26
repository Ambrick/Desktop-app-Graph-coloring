using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Graph_coloring
{
    public class DataBaseManager
    {
        private Graphics graphics;

        //Переименовать в графМанагер
        public DataBaseManager(Graphics graphics)
        {
            this.graphics = graphics;
        }

        public Graph Open()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog {
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            Random rand = new Random();
            Graph graph = new Graph(graphics);

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Не удалось открыть!");
                return graph;
            }

            string fileName = openFileDialog.FileName;
            string text = File.ReadAllText(fileName);
            
            using (StringReader sr = new StringReader(text))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    //**добавить норм функцию добавления вершины
                    //**добавить норм размеры с пикчербокса
                    graph.vertexesList.Add(new Vertex(new Point(rand.Next(650), rand.Next(500)), 14, graph.index, graphics));
                    int i = 0;
                    while (line.Length != 0)
                    {
                        if (line.Substring(0, 1) == "1")
                        {
                            graph.ribsList.Add(new Point(graph.index, i));
                        }
                        line = line.Substring(1);
                        i++;
                    }
                    graph.index++;
                }
            }

            return graph;
        }

        public void SaveToFile(ref Graph graph)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "txt files (*.txt)|*.txt",
                Title = "Save graph in txt file"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Не удалось сохранить!");
                return;
            }

            string fileName = saveFileDialog.FileName;
            File.WriteAllText(fileName, GenerateTextForSavingFromGraph(ref graph));
            MessageBox.Show("Успешно сохранено!");
        }

        private string GenerateTextForSavingFromGraph(ref Graph graph)
        {
            int MatrixSize = graph.vertexesList.Count();
            string text = "";

            for (int i = 0; i < MatrixSize; i++)
            {
                int VertexIndexI = graph.vertexesList[i].index;
                for (int j = 0; j < MatrixSize; j++)
                {
                    int VertexIndexJ = graph.vertexesList[j].index;

                    if (graph.ribsList.Contains(new Point(VertexIndexI, VertexIndexJ)))
                        text += "1";
                    else
                        text += "0";
                }
                text += Environment.NewLine;
            }
            return text;
        }
    }
}
