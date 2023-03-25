<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Document</title>
</head>
<body>
    <h1>Elementos básicos</h1>
    <h2>Ejercicio 7</h2>

    <h3>Este contador va del 1 al 100</h3>
    <?php
        $coma = 0;
        for($i = 1 ; $i < 101 ; $i++)
        {
            if ($coma > 0)
                echo ",";
            echo $i;
            $coma++;
        }
    ?>

    <h3>Este otro va del 10 al 0:</h3>
        
    <?php
        $contador = 10;

        while($contador >= 0)
        {
            echo $contador;
            if ($contador > 0)
                echo "-";
            $contador--;
        }
    ?>
</body>
</html>