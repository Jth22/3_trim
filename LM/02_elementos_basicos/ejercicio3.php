<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Elementos básicos</h1>
    <h2>Ejercicio 3</h2>
    <?php
        $num1 = 3;
        $num2 = 5;
        $num3 = 8;
        $num1 *= 4;
        echo $num1;
        echo $num1 <= $num2;
        echo $num3 > $num1 and $num3 > $num2;
        echo $num3 > $num1 or $num3 > $num2;
        echo $num1 > $num2 xor $num1 > $num3;
        $num3--;
        echo $num3;
        $num3 += $num1;
        echo $num3;
    ?>
</body>
</html>