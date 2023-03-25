<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Document</title>
</head>
<body>
    <h1>Elementos básicos</h1>
    <h2>Ejercicio 6</h2>
    <?php
        $coma = 0;
        for($i = 1 ; $i < 101 ; $i++)
        {
            if ($coma > 0)
                echo ",";
            echo $i;
            $coma++;
        }

        $contador = 11;

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