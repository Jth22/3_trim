<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Document</title>
</head>
<body>
    <h1>Elementos básicos</h1>
    <h2>Ejercicio 5</h2>

    <?php
        $nota1 = 9;
        $nota2 = 7;
        $nota3 = 8;

        if ($nota1 > $nota2 && $nota1 > $nota3)
        {
            echo "La nota 1 (".$nota1.") es la mayor";
        }
        elseif ($nota1 < $nota2 && $nota3 < $nota2)
        {
            echo "la nota 2 (".$nota2.") es la mayor";
        }
        else
        {
            echo "la nota 3 (".$nota3.") es la mayor";
        }

    ?>
</body>
</html>