<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Document</title>
</head>
<body>
    <h1>Funciones</h1>
    <h2>Ejercicio 6</h2>
    <?php
        define ('PI',3.1415);
        $radio = 2;
        $area = (PI * $radio * $radio);

        $textoResultado = "El área calculada del círculo es ".number_format($area,2);

        echo $textoResultado;

        echo "<br>";
        $textoResultadoMayus = strtoupper($textoResultado);
        echo $textoResultadoMayus;
    ?>
</body>
</html>