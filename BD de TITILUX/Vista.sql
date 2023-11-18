CREATE VIEW VistaRolesYChoferes AS
SELECT
    RU.Usuario,
    RU.Rol,
    R.NombreRol,
    C.Ci,
    C.Nombre AS NombreChofer,
    C.Apellido AS ApellidoChofer,
    C.Telefono,
    C.Licencia
FROM
    Rol_Usuario RU
JOIN roles R ON RU.Rol = R.ID
JOIN Chofer C ON RU.Usuario = C.Nombre;

CREATE VIEW VistaActividadesCamiones AS
SELECT
    AC.Id_ActividadCamion,
    AC.Tarea,
    AC.Fecha_Hora,
    AC.UbicacionAlmacen,
    C.Id AS Id_Camion,
    C.Matricula,
    C.Seguro,
    C.Capacidad
FROM
    ActividadCamiones AC
JOIN Camion C ON AC.Id_Camion = C.Id;