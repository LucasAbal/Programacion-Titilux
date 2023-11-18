create database distribucion;
use distribucion;

CREATE USER 'lcordoba'@'localhost' IDENTIFIED BY '1234';
CREATE USER 'labal'@'localhost' IDENTIFIED BY '1234';
CREATE USER 'tfernandez'@'localhost' IDENTIFIED BY '1234';

CREATE USER 'AIngreso'@'localhost' IDENTIFIED BY '1234';
CREATE USER 'AAlmacen'@'localhost' IDENTIFIED BY '1234';

GRANT ALL PRIVILEGES ON *.* TO 'AIngreso'@'localhost';
GRANT ALL PRIVILEGES ON *.* TO 'AAlmacen'@'localhost';

GRANT ALL PRIVILEGES ON *.* TO 'labal'@'localhost';
GRANT ALL PRIVILEGES ON *.* TO 'lcordoba'@'localhost';
GRANT ALL PRIVILEGES ON *.* TO 'tfernandez'@'localhost';
FLUSH PRIVILEGES;

SELECT user, host FROM mysql.user;