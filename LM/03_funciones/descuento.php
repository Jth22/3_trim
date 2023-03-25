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
    <h2>Ejercicio 4</h2>
    <?php
        $precioFinal1 = calculaDescuento(100, 0.1);
        $precioFinal2 = calculaDescuento(85);

        echo "Precio final 1 = ".$precioFinal1;
        echo "<br>";
        echo "Precio final 2 = ".$precioFinal2;
    ?>
</body>
</html>