SELECT e.event_id, e.title, s1.session_id AS session1_id, s2.session_id AS session2_id
FROM Sessions s1
JOIN Sessions s2 ON s1.event_id = s2.event_id AND s1.session_id < s2.session_id
JOIN Events e ON s1.event_id = e.event_id
WHERE s1.start_time < s2.end_time AND s1.end_time > s2.start_time;