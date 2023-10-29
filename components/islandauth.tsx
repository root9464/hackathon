'use client'
import Box from '@mui/material/Box';
import Modal from '@mui/material/Modal';
import Button from '@mui/material/Button';
import { useState } from 'react';
import { FormControl } from '@mui/material';
import { Form } from './form';

function ChildModal(){
    const [open, setOpen] = useState<boolean>(false);
    const handleOpen = () => {
      setOpen(true);
    };
    const handleClose = () => {
      setOpen(false);
    };
    return(
        <div>
            <Button onClick={handleOpen}>Авторизация</Button>
            <Modal
                className='modal'
                open={open}
                onClose={handleClose}
                aria-labelledby="child-modal-title"
                aria-describedby="child-modal-description"
            >
            <Box className="modal-box">
            <h2 id="child-modal-title">Text in a child modal</h2>
            <p id="child-modal-description">
                Lorem ipsum, dolor sit amet consectetur adipisicing elit.
            </p>
            <Button onClick={handleClose}>Close Child Modal</Button>
            </Box>
        </Modal>
        </div>
    )
}


const Auth = () => {
    const [open, setOpen] = useState<boolean>(false);
    const handleOpen = () => {
        setOpen(true);
    };
    const handleClose = () => {
        setOpen(false);
    };
    return(
        <div>
            <Button onClick={handleOpen}>Open modal</Button>
            <Modal
                open={open}
                onClose={handleClose}
                aria-labelledby="parent-modal-title"
                aria-describedby="parent-modal-description"
            >
                <Box className="modal-box" >
                    <div className="modal-pos">
                        <h2 id="parent-modal-title">Регистрация</h2>
                        <Form/>
                        <button type="submit">sub</button>
                    </div>
                <ChildModal />
                </Box>
            </Modal>
        </div>
    )
}

export { Auth }