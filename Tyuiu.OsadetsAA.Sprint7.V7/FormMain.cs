using Tyuiu.OsadetsAA.Sprint7.V7.Lib;
using CsvHelper;
using CsvHelper.Configuration;
using System.Buffers;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.OsadetsAA.Sprint7.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();


            dataGridViewRecords_OAA.ColumnCount = 10;
            dataGridViewRecords_OAA.Columns[0].Name = "Номер подъезда";
            dataGridViewRecords_OAA.Columns[1].Name = "Номер квартиры";
            dataGridViewRecords_OAA.Columns[2].Name = "Общая площадь";
            dataGridViewRecords_OAA.Columns[3].Name = "Полезная площадь";
            dataGridViewRecords_OAA.Columns[4].Name = "Количество комнат";
            dataGridViewRecords_OAA.Columns[5].Name = "Фамилия арнедатора";
            dataGridViewRecords_OAA.Columns[6].Name = "Дата регистрации";
            dataGridViewRecords_OAA.Columns[7].Name = "Количество членов семьи";
            dataGridViewRecords_OAA.Columns[8].Name = "Количество детей";
            dataGridViewRecords_OAA.Columns[9].Name = "Задолженность по квартплате";

            ToolStripStatusLabel statusLabel_OAA = new ToolStripStatusLabel("Готово");
            ToolStripProgressBar progressBar_OAA = new ToolStripProgressBar();
            ToolStripStatusLabel recordCountLabel_OAA = new ToolStripStatusLabel("Записей: 0");

            // Добавление в StatusStrip
            statusStripOfProg_OAA.Items.Add(statusLabel_OAA);
            statusStripOfProg_OAA.Items.Add(progressBar_OAA);
            statusStripOfProg_OAA.Items.Add(recordCountLabel_OAA);

            

            
            comboBoxFunction_OAA.Items.Add("Количество комнат");
            comboBoxFunction_OAA.Items.Add("Сумма задолженности");
            comboBoxFunction_OAA.SelectedIndex = 0; // По умолчанию выбираем "Количество комнат"

            // Подписка на события
            dataGridViewRecords_OAA.RowsAdded += (s, e) => UpdateStatusLabel();
            dataGridViewRecords_OAA.RowsRemoved += (s, e) => UpdateStatusLabel();
            dataGridViewRecords_OAA.CellValueChanged += (s, e) => UpdateStatusLabel();

            // Если требуется обновить статус после загрузки данных
            dataGridViewRecords_OAA.DataBindingComplete += (s, e) => UpdateStatusLabel();

            // Инициализация первого состояния
            UpdateStatusLabel();
        }

        private void UpdateStatusLabel()
        {
            // Подсчет строк (без учета строки для добавления новых данных)
            int rowCount = dataGridViewRecords_OAA.Rows.Count - 1;

            // Подсчет всех заполненных ячеек
            int filledCellsCount = 0;
            foreach (DataGridViewRow row in dataGridViewRecords_OAA.Rows)
            {
                if (!row.IsNewRow)
                {
                    filledCellsCount += row.Cells.Cast<DataGridViewCell>()
                                                 .Count(cell => cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()));
                }
            }

            // Обновление текста в StatusLabel
            ToolStripStatusLabel recordCountLabel_OAA = (ToolStripStatusLabel)statusStripOfProg_OAA.Items[2];
            recordCountLabel_OAA.Text = $"Строк: {rowCount}, Заполненных ячеек: {filledCellsCount}";
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        public void LoadFromFileData()
        {
            // Открываем диалог для выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            openFileDialog.Title = "Выберите файл для загрузки";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    // Открываем файл для чтения
                    using (var reader = new StreamReader(filePath, Encoding.UTF8))
                    {
                        // Читаем все строки из файла
                        var lines = new List<string>();
                        while (!reader.EndOfStream)
                        {
                            lines.Add(reader.ReadLine());
                        }

                        // Если файл не пустой
                        if (lines.Count > 0)
                        {

                            // Добавляем остальные строки как данные в DataGridView
                            for (int i = 0; i < lines.Count; i++)
                            {
                                var row = lines[i].Split(';');

                                // Добавляем каждое значение как отдельную ячейку
                                dataGridViewRecords_OAA.Rows.Add(row);

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке файла: " + ex.Message);
                }
            }
            UpdateStatusLabel();
        }

        

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFromFileData();
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();
        }

        private bool SearchValueInDataGridView(DataGridView dataGridView, string searchValue)
        {
            bool found = false; // Флаг, указывающий, что хотя бы одно совпадение найдено

            // Проходим по каждой строке в DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Пропускаем пустую строку (это последняя строка в DataGridView для добавления новых данных)
                if (row.IsNewRow) continue;

                bool rowFound = false; // Флаг для строки, если в ней есть хотя бы одно совпадение

                // Проходим по каждой ячейке в текущей строке
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Получаем значение ячейки (если оно есть)
                    string? cellValue = cell.Value?.ToString();

                    // Проверяем, содержит ли ячейка поисковое значение
                    if (!string.IsNullOrEmpty(cellValue) && cellValue.Contains(searchValue, StringComparison.OrdinalIgnoreCase))
                    {
                        rowFound = true; // Если есть совпадение, устанавливаем флаг
                        break; // Прерываем проверку остальных ячеек в строке
                    }
                }

                if (rowFound) // Если в строке было найдено совпадение
                {
                    row.Selected = true; // Выделяем всю строку
                    found = true; // Устанавливаем общий флаг о наличии совпадений
                }
            }

            return found;
        }

        private void toolStripButtonSearch_OAA_Click_1(object sender, EventArgs e)
        {
            // Получаем текст из текстового поля (без лишних пробелов)
            string searchValue = toolStripTextBoxFind_OAA.Text.Trim();

            // Сначала снимаем выделение со всех строк
            dataGridViewRecords_OAA.ClearSelection();

            // Проверяем, что поле поиска не пустое
            if (!string.IsNullOrEmpty(searchValue))
            {
                // Ищем значение в DataGridView
                bool found = SearchValueInDataGridView(dataGridViewRecords_OAA, searchValue);

                if (found)
                {
                    MessageBox.Show("Найдено одно или несколько совпадений.");
                }
                else
                {
                    MessageBox.Show("Значение не найдено.");
                }
            }
            else
            {
                MessageBox.Show("Введите значение для поиска.");
            }
        }

        private void GenerateRoomCountGraph()
        {
            // Очищаем текущие данные на графике
            chartStatistics_OAA.Series.Clear();
            chartStatistics_OAA.Legends.Clear();

            // Создаем новый ряд для графика
            var series = new Series("Количество квартир");
            series.ChartType = SeriesChartType.Column; // Гистограмма (столбчатая диаграмма)
            chartStatistics_OAA.Series.Add(series);

            // Список для хранения количества квартир по каждому подъезду
            List<int> entrances = new List<int>();  // Список для номеров подъездов
            List<int> apartmentCounts = new List<int>(); // Список для количества квартир в подъездах

            // Проходим по каждой строке в DataGridView
            foreach (DataGridViewRow row in dataGridViewRecords_OAA.Rows)
            {
                // Пропускаем пустую строку (это последняя строка в DataGridView для добавления новых данных)
                if (row.IsNewRow) continue;

                // Получаем значения из столбцов (Номер подъезда и Номер квартиры)
                string? подъезд = row.Cells[0].Value?.ToString()?.Trim();  // Номер подъезда, убираем пробелы
                string? квартира = row.Cells[1].Value?.ToString()?.Trim();  // Номер квартиры, убираем пробелы

                // Проверяем, что данные не пустые
                if (!string.IsNullOrEmpty(подъезд) && !string.IsNullOrEmpty(квартира))
                {
                    // Преобразуем номер подъезда в число
                    int entranceNumber = int.Parse(подъезд);

                    // Ищем, есть ли уже такой подъезд в списке
                    int index = entrances.IndexOf(entranceNumber);

                    if (index == -1)  // Если такого подъезда нет в списке
                    {
                        // Добавляем новый подъезд и инициализируем количество квартир для этого подъезда
                        entrances.Add(entranceNumber);
                        apartmentCounts.Add(1);  // Начинаем с 1 квартиры в этом подъезде
                    }
                    else  // Если такой подъезд уже есть
                    {
                        // Увеличиваем счетчик квартир в этом подъезде
                        apartmentCounts[index]++;
                    }
                }
            }

            // Заполняем данные в график
            for (int i = 0; i < entrances.Count; i++)
            {
                // Для каждого подъезда добавляем данные в график
                series.Points.AddXY(entrances[i], apartmentCounts[i]); // X - номер подъезда, Y - количество квартир
            }

            // Настройка осей графика
            chartStatistics_OAA.ChartAreas[0].AxisX.Title = "Номер подъезда";
            chartStatistics_OAA.ChartAreas[0].AxisY.Title = "Количество квартир";
            chartStatistics_OAA.ChartAreas[0].AxisX.Interval = 1;
            chartStatistics_OAA.ChartAreas[0].AxisY.Interval = 10;  // Интервал для количества квартир
        }
        private void GenerateDebtGraph()
        {
            // Очищаем текущие данные на графике
            chartStatistics_OAA.Series.Clear();
            chartStatistics_OAA.Legends.Clear();

            // Создаем новый ряд для графика
            var series = new Series("Сумма задолженности");
            series.ChartType = SeriesChartType.Column; // Гистограмма (столбчатая диаграмма)
            chartStatistics_OAA.Series.Add(series);

            // Список для хранения суммы задолженности по каждому подъезду
            List<int> entrances = new List<int>();  // Список для номеров подъездов
            List<decimal> debtSums = new List<decimal>(); // Список для суммы задолженности по подъездам

            // Проходим по каждой строке в DataGridView
            foreach (DataGridViewRow row in dataGridViewRecords_OAA.Rows)
            {
                // Пропускаем пустую строку (это последняя строка в DataGridView для добавления новых данных)
                if (row.IsNewRow) continue;

                // Получаем значения из столбцов (Номер подъезда и Задолженность по квартплате)
                string? подъезд = row.Cells[0].Value?.ToString()?.Trim();  // Номер подъезда, убираем пробелы
                string? задолженность = row.Cells[9].Value?.ToString()?.Trim();  // Задолженность по квартплате, убираем пробелы

                // Проверяем, что данные не пустые
                if (!string.IsNullOrEmpty(подъезд) && !string.IsNullOrEmpty(задолженность))
                {
                    // Преобразуем номер подъезда в число
                    int entranceNumber = int.Parse(подъезд);

                    // Преобразуем задолженность в десятичное значение
                    decimal debtAmount;
                    if (decimal.TryParse(задолженность, out debtAmount))
                    {
                        // Ищем, есть ли уже такой подъезд в списке
                        int index = entrances.IndexOf(entranceNumber);

                        if (index == -1)  // Если такого подъезда нет в списке
                        {
                            // Добавляем новый подъезд и инициализируем сумму задолженности для этого подъезда
                            entrances.Add(entranceNumber);
                            debtSums.Add(debtAmount);  // Начинаем с текущей задолженности
                        }
                        else  // Если такой подъезд уже есть
                        {
                            // Увеличиваем сумму задолженности для этого подъезда
                            debtSums[index] += debtAmount;
                        }
                    }
                }
            }

            // Заполняем данные в график
            for (int i = 0; i < entrances.Count; i++)
            {
                // Для каждого подъезда добавляем данные в график
                series.Points.AddXY(entrances[i], debtSums[i]); // X - номер подъезда, Y - сумма задолженности
            }

            // Настройка осей графика
            chartStatistics_OAA.ChartAreas[0].AxisX.Title = "Номер подъезда";
            chartStatistics_OAA.ChartAreas[0].AxisY.Title = "Сумма задолженности";
            chartStatistics_OAA.ChartAreas[0].AxisX.Interval = 1;  // Интервал по оси X для подъездов
            chartStatistics_OAA.ChartAreas[0].AxisY.Interval = 20000;  // Интервал по оси Y для суммы задолженности
        }

        private void comboBoxFunction_OAA_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Если выбран вариант "Количество комнат", генерируем график
            if (comboBoxFunction_OAA.SelectedItem.ToString() == "Количество комнат")
            {
                GenerateRoomCountGraph();
            }
            else
            {
                GenerateDebtGraph();
            }
        }

        private void сохранитьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем диалог для выбора места и имени файла
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                Title = "Сохранить данные в файл"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    // Создаем файл для записи
                    using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                    {
                        // Записываем данные строк из DataGridView, начиная с первой строки (без заголовков)
                        foreach (DataGridViewRow row in dataGridViewRecords_OAA.Rows)
                        {
                            // Пропускаем пустую строку для добавления новых данных
                            if (row.IsNewRow) continue;

                            var cellValues = row.Cells.Cast<DataGridViewCell>()
                                                      .Select(cell => cell.Value?.ToString() ?? string.Empty);
                            writer.WriteLine(string.Join(";", cellValues));
                        }
                    }

                    MessageBox.Show("Данные успешно сохранены в файл.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
                }
            }
        }

        private void toolStripButtonCleanTable_OAA_Click(object sender, EventArgs e)
        {
            dataGridViewRecords_OAA.Rows.Clear();
            for (int i = 1; i < dataGridViewRecords_OAA.Rows.Count; i++)
            {
                dataGridViewRecords_OAA.Columns.Clear();
            }
            UpdateStatusLabel();
        }
        string filePath = @"C:\Users\Mecht\OneDrive\Рабочий стол\Файлы для спринт 7\Домоуправление.csv";
        private void buttonDone_OAA_Click(object sender, EventArgs e)
        {
            var square = DataService.LoadAreasFromCsv(filePath);
            double averageGrade = DataService.CalculateAverageArea(square);
            textBoxMiddle_OAA.Text = averageGrade.ToString();
            double CalculateMinimumSquare = DataService.CalculateMinArea(square);
            textBoxMin_OAA.Text = CalculateMinimumSquare.ToString();
            double CalculateMaximumSquare = DataService.CalculateMaxArea(square);
            textBoxMax_OAA.Text = CalculateMaximumSquare.ToString();
        }
    }
}
