<h1>Библиотека компьютерного зрения</h1>
<p>Нужна для обработки изображений</p>
<p>Написана на языках C++</p>
<p>Можно писать на C#, Phyton</p>
<p>Меняется только структура</p>
<p>Создали общий стандарт для всех языков</p>
<p>IBM, Microsoft, Sony и тд. поддерживают эту систему</p>
<p>Она постоянно обновляется</p>
<p>Поддерживается на системах windows и linux</p>
<p>Позволяет фильтровать, преобразовывать, анализировать движение, обнаруживать объекты</p>
<p>Матрица в openCV используется для хранения всех объектов - изображений, массивов точек, векторных полей и тд</p>
<p>Аналогично MATLAB </p>
<p>Класс cv::Mat реализует многоканальные массивы</p>
<p>Один столбец матрицы - вектор</p>
<p>Библиотеки - в них хранится код заранее подготовленный код</p>
<p>Пространство имен (namespace) - например cv::</p>

<p>Объявление матрцы, в которой хранится изображение cv::Mat img;</p>

<b>Задания:</b>
1. Нахождение контуров в изображении.
  0. Создание проекта с OpenCV, рисование окна
      Скрин окна и замена текста
  1. Найти изображени и загруить в проект
  2. Функция imread()
  3. Обработать изображение cvtColor(), blur(), Canny()  выложить на гит
       Imwrite() - сохранить изображение
       Imshow() - показать
  4. Найти контуры - findContours() и drawContours() и сохранить изображение imwrite().

<h1>Оператор Canny().</h1>
Получил свое название в честь математика разработавшего фильтр
Состоит из этапов: 
<ul>
<li>Преобразование в оттенки серого - rgb2gray</li>
<li>Сглаживание blur() </li>
    Гаусс: отсекает 
<li>Передали градиент - направление. рисует вместо каждого пикселя стрелочку</li>
<li>Они считаются контуром, если имеют одно направление и максимальную яркость - подавление</li>
<li>vector </li>
  </ul>
