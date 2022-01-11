SELECT * FROM EMPLOYEE

-- Utilisation de la m�thode Convert pour convertir un INT en VARCHAR
-- Syntaxe CONVERT(VARCHAR, Emp.DEPT_ID)
-- Possibilit� de concat�ner avec +
-- Si cr�ation de colonne , utiliser 'AS' Pour D�finir le nom de cette colonne

SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.DEPT_ID,
		'DEPT'+ CONVERT(VARCHAR, Emp.DEPT_ID) AS Emp_DeptId_VARCHAR
FROM EMPLOYEE Emp