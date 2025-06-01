SELECT DATE_FORMAT(registration_date, '%Y-%m') AS month, COUNT(registration_id) AS registrations
FROM Registrations
GROUP BY month
ORDER BY month;