SELECT * FROM EMPLOYEE

-- Utilisation de la méthode Convert pour convertir un INT en VARCHAR
-- Syntaxe CONVERT(VARCHAR, Emp.DEPT_ID)
-- Possibilité de concaténer avec +
-- Si création de colonne , utiliser 'AS' Pour Définir le nom de cette colonne

SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.DEPT_ID,
		'DEPT'+ CONVERT(VARCHAR, Emp.DEPT_ID) AS Emp_DeptId_VARCHAR
FROM EMPLOYEE Emp