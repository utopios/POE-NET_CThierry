-- Affichage de la Table EMPLOYEE
SELECT Emp.* FROM EMPLOYEE Emp

-- Requ�te des recherche des employ�s dont le nom commence par "S"
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
FROM EMPLOYEE Emp
WHERE Emp.FIRST_NAME LIKE 'S%'

-- Requ�te des recherche des employ�s dont le nom commence par "S"
-- Et Travail dans le departement ID = 1
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
FROM EMPLOYEE Emp
WHERE Emp.FIRST_NAME LIKE 'S%'
AND Emp.DEPT_ID = 1

-- Requ�te des recherche des employ�s dont le nom commence par "S"
-- Et Travail dans le departement ID = 1
-- Et occupe le poste de caissier (teller)
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
FROM EMPLOYEE Emp
WHERE Emp.FIRST_NAME LIKE 'S%'
AND Emp.DEPT_ID = 1
AND Emp.TITLE = 'Teller'

-- Requ�te des recherche des employ�s dont le nom commence par "S" ou un "J"
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
FROM EMPLOYEE Emp
WHERE Emp.FIRST_NAME LIKE 'S%'
OR Emp.FIRST_NAME LIKE 'J%'

-- Requ�te des recherche des employ�s dont le nom termine par "an" ou "en"
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
FROM EMPLOYEE Emp
WHERE Emp.FIRST_NAME LIKE '%an'
OR Emp.FIRST_NAME LIKE '%en'

-- Requ�te des recherche de l'employ�s dont le pr�nom est "Susan" et le nom "Barker"
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
FROM EMPLOYEE Emp
WHERE Emp.FIRST_NAME LIKE 'Susan'
AND Emp.LAST_NAME LIKE 'Barker'