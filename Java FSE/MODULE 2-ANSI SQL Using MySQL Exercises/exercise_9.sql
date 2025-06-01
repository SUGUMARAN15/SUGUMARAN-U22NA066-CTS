SELECT u.user_id, u.full_name, 
       COUNT(e.event_id) AS event_count,
       GROUP_CONCAT(DISTINCT e.status ORDER BY e.status SEPARATOR ', ') AS statuses
FROM Events e
JOIN Users u ON e.organizer_id = u.user_id
GROUP BY u.user_id, u.full_name;