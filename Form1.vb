Public Class Form1
    Public questions(10) As String ' Массив с вопросами.
    Public questions_count As Integer = 10 ' Количество вопросов, менять только в случае, если в массиве присутствует достаточное количество вопросов.
    Public answers(40) As String ' Доступные ответы - количество вопросов * 4 (т.к. у каждого вопроса 4 ответа), менять только в случае, если в массиве присутствует достаточное количество ответов.
    Public answers_a(10) As Integer ' Правильные ответы на вопросы. Количество правильных ответов равно количеству вопросов.
    Public answer As Integer = 0 ' Переменная, хранящая номер ответа на вопрос, 0 - ответ не выбран, 1-4 - выбранный ответ. ЗНАЧЕНИЕ ВРУЧНУЮ НЕ ИЗМЕНЯТЬ.
    Public i As Integer = 0 ' Счётчик для вопросов. ВРУЧНУЮ НЕ ИЗМЕНЯТЬ.
    Public true_answers_count As Integer = 0 ' Счётчик правильных ответов. ВРУЧНУЮ НЕ ИЗМЕНЯТЬ.
    Public Function config() ' Функция конфигурации, здесь вы можете ввести тестовый материал.
        questions = { ' Массив вопросов.
        "Электронными таблицами являются следующие приложения:", ' Первый вопрос. Новая строка - новый вопрос.
        "Прикладное программное обеспечение представляет собой:",
        "К какому классу программного обеспечения принадлежат табличные редакторы?",
        "Прикладные программы также называют:",
        "К приложениям специального назначения относятся:",
        "К приложениям общего назначения относятся:",
        "К приложениям общего назначения относятся:",
        "К приложениям специального назначения относятся:",
        "Какие из приведенных названий приложений относятся к классу прикладного ПО общего назначения:",
        "Какое из перечисленных названий обозначает класс прикладного программного обеспечения:"} ' Десятый вопрос, конец массива.
        answers = { ' Массив ответов.
            "Word", "Excel", "Access", "Powerpoint", ' Ответы на первый вопрос. Новая строка - новая четвёрка ответов.
            "программы для защиты от компьютерных вирусов", "программы для обеспечения работы периферийного устройства", "программы для решения пользовательских задач обработки информации различного вида", "программы для обслуживания дискового пространства",
            "Системного программного обеспечения", "Прикладного программного обеспечения общего назначения", "Интегрированных сред разработки приложений", "Специализированного прикладного программного обеспечению",
            "драйверами", "утилитами", "браузерами", "приложениями",
            "Программы для создания баз данных", "Интегрированные среды разработки приложений", "Экспертные системы", "Программы очистки дискового пространства",
            "Программы для создания графических файлов", "Программы для подготовки печатной продукции", "Медицинские экспертные системы", "Программы для ведения бухгалтерского учета",
            "Сервисные программы", "Программы для разработки пользовательских приложений", "Редакторы создания презентаций", "Геоинформационные системы",
            "Программы для выполнения вычислений в электронных таблицах", "Программы для автоматизированного проектирования", "Операционные системы", "Программы для разработки других программ",
            "MathCad", "Microsoft Access", "AutoCad", "1С бухгалтерия",
            "специализированное", "сервисное", "системное", "стандартизированное"} ' Ответы на десятый вопрос, конец массива.
        answers_a = {2, 3, 2, 4, 3, 1, 3, 2, 2, 1} ' Номера правильных ответов. Номер позиции ответа соответствует номеру вопроса.
        Return 0 ' Возвращаем код успешного завершения выполнения функции. Это надо, чтобы IDE не ругалась.
    End Function

    Public Function next_question()
        If i < (questions_count * 4) Then
            ProgressBar1.Value = i / 4 + 1
            Label2.Text = "Вопрос " + (i / 4 + 1).ToString + " из " + questions_count.ToString
            Label3.Text = questions(i / 4)
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            RadioButton1.Text = answers(i)
            RadioButton2.Text = answers(i + 1)
            RadioButton3.Text = answers(i + 2)
            RadioButton4.Text = answers(i + 3)
        End If
        Return 0 ' Возвращаем код успешного завершения выполнения функции. Это надо, чтобы IDE не ругалась.
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load ' Основная функция загрузки формы, срабатывает при запуске приложения.
        config()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        Label3.Text = questions(0)
        RadioButton1.Text = answers(0)
        RadioButton2.Text = answers(1)
        RadioButton3.Text = answers(2)
        RadioButton4.Text = answers(3)
        ProgressBar1.Value = 1
        Label2.Text = "Вопрос 1 из " + questions_count.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click ' кнопка "Далее".
        If i < (questions_count * 4) Then
            If answer = answers_a(i / 4) Then
                true_answers_count += 1
            End If
        End If

        answer = 0
        i += 4
        next_question()
        If Button1.Text = "Выход" Then 'Проверяем, отвечает ли эта кнопка за выход, если да - закрываем приложение.
            Close()
        End If
        If i >= (questions_count * 4) Then
            Label1.Text = "Ваш результат:"
            Label3.Text = true_answers_count.ToString + " из " + questions_count.ToString + " (" + ((true_answers_count / questions_count) * 100).ToString + "%)" ' Выводим результат тестирования(даже с процентами).
            RadioButton1.Visible = False
            RadioButton2.Visible = False
            RadioButton3.Visible = False
            RadioButton4.Visible = False
            Button1.Text = "Выход" 'Меняем кнопку "Далее" на кнопку "Выход".
            Button1.BackColor = Color.Red 'Меняем цвет кнопки на красный.
            Label2.Visible = False
            ProgressBar1.Visible = False
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged ' Первый ответ.
        answer = 1
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged ' Второй ответ.
        answer = 2
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged ' Третий ответ.
        answer = 3
    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged ' Четвёртый ответ.
        answer = 4
    End Sub
End Class
