import React, { useState, useEffect } from 'react';

const UserCard = () => {
  const defaultName = 'Пользователь';
  const [userName, setUserName] = useState(defaultName);
  const [confirmedName, setConfirmedName] = useState(null);

  useEffect(() => {
    console.log(`Имя изменилось на: "${userName}"`);
  }, [userName]);

  useEffect(() => {
    if (confirmedName !== null) {
      console.log(`Подтверждённое имя: "${confirmedName}"`);
    }
  }, [confirmedName]);

  const handleNameChange = (e) => {
    setUserName(e.target.value);
  };

  const handleReset = () => {
    setUserName(defaultName);
    setConfirmedName(null);
  };

  const handleConfirm = () => {
    setConfirmedName(userName);
  };

  return (
    <div style={{ 
      padding: '20px', 
      border: '1px solid #ddd', 
      borderRadius: '8px', 
      width: '300px',
      fontFamily: 'Arial, sans-serif'
    }}>
      <h2 style={{ marginTop: 0 }}>Карточка пользователя</h2>
      <p>Текущее имя: <b>{userName}</b></p>
      {confirmedName && <p>Подтверждённое имя: <b style={{color: 'green'}}>{confirmedName}</b></p>}
      
      <input
        type="text"
        value={userName}
        onChange={handleNameChange}
        placeholder="Введите имя"
        style={{ 
          padding: '8px',
          width: '100%',
          marginBottom: '10px',
          boxSizing: 'border-box'
        }}
      />
      
      <div style={{ display: 'flex', gap: '10px' }}>
        <button
          onClick={handleReset}
          style={{
            padding: '8px 16px',
            backgroundColor: '#f0f0f0',
            border: '1px solid #999',
            borderRadius: '4px',
            cursor: 'pointer',
            flex: 1
          }}
        >
          Сбросить
        </button>

        <button
          onClick={handleConfirm}
          style={{
            padding: '8px 16px',
            backgroundColor: '#4CAF50',
            color: 'white',
            border: 'none',
            borderRadius: '4px',
            cursor: 'pointer',
            flex: 1
          }}
        >
          Подтвердить
        </button>
      </div>
    </div>
  );
};

export default UserCard;