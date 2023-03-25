<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Document</title>
</head>
<body>
    <h1>Elementos básicos</h1>
    <h2>Ejercicio 4</h2>

    <?php
        $nota1 = 9;
        $nota2 = 7;

        if ($nota1 > $nota2)
        {
            echo "La nota ".$nota1." es la mayor";
        }
        elseif ($nota1 < $nota2)
        {
            echo "la nota ".$nota2." es la mayor";
        }
        else
        {
            echo "las notas ".$nota1." y ".$nota2." son iguales";
        }

    ?>
</body>
</html>