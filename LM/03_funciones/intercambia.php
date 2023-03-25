<?php
    include "funciones.inc";
?>
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Document</title>
</head>
<body>
    <h1>Funciones</h1>
    <h2>Ejercicio 3</h2>
    <?php
        $a = 2;
        $b = 3;
        echo "Antes: ";
        echo $a;
        echo $b;
        intercambia($a, $b);
        echo "<br>";
        echo "Después: ";
        echo $a;
        echo $b;
    ?>
</body>
</html>