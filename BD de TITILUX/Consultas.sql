-- consultas --
-- 1 --
SELECT p.Id, p.Peso, p.Tamano
FROM Paquete p
JOIN Domicilio d ON p.Envio_Num_Puerta = d. Num_Puerta
WHERE MONTH(p.Fecha_Entrega) = 5 
AND YEAR(p.Fecha_Entrega) = 2023 
AND d.Departamento = 'Melo';    

-- 2 --
SELECT a.Id AS 'ID_Almacen', a.Ubicacion AS 'Ubicacion_Almacen', COUNT(p.Id) AS 'Cantidad_Paquetes_Recibidos'
FROM Almacen a
LEFT JOIN Lote l ON a.Id = l.Alm_Envio
LEFT JOIN Paquete p ON l.Id = p.Id
WHERE YEAR(p.Fecha_Entrega) = 2023
GROUP BY a.Id, a.Ubicacion
ORDER BY COUNT(p.Id) DESC;

-- 3 --
SELECT c.Id AS 'ID_Camion', c.Matricula, ac.Tarea
FROM Camion c
LEFT JOIN ActividadCamiones ac ON c.Id = ac.Id_Camion;

-- 4 -- 

SELECT c.Id AS 'ID_Camion', c.Matricula, ac.Fecha_Hora
FROM Camion c
JOIN ActividadCamiones ac ON c.Id = ac.Id_Camion
WHERE MONTH(ac.Fecha_Hora) = 6 -- Junio
AND ac.UbicacionAlmacen = 'Almacen';


-- 5 -- 

SELECT d.Departamento AS 'Destino',
       l.Id AS 'Lote',
       a.Ubicacion AS 'Almacen_Destino',
       c.Matricula AS 'Matricula_Camion'
FROM Paquete p
JOIN Lote l ON p.Id = l.Id
JOIN Almacen a ON l.Alm_Envio = a.Id
JOIN Camion c ON p.Id = c.Id
JOIN Domicilio d ON p.Envio_Num_Puerta = d.Num_Puerta
WHERE p.Id = 'Paquete';